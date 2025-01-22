using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003B8 RID: 952
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectorySettingsEvent : IMessage<JobCrafterDirectorySettingsEvent>, IMessage, IEquatable<JobCrafterDirectorySettingsEvent>, IDeepCloneable<JobCrafterDirectorySettingsEvent>, IBufferMessage
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x001CD938 File Offset: 0x001CBB38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectorySettingsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x001CD948 File Offset: 0x001CBB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x001CD958 File Offset: 0x001CBB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x001CD968 File Offset: 0x001CBB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsEvent()
		{
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x001CD978 File Offset: 0x001CBB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsEvent(JobCrafterDirectorySettingsEvent other)
		{
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x001CD988 File Offset: 0x001CBB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsEvent Clone()
		{
			return null;
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x001CD998 File Offset: 0x001CBB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JobCrafterDirectorySettings> Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x001CD9A8 File Offset: 0x001CBBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x001CD9B8 File Offset: 0x001CBBB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectorySettingsEvent other)
		{
			return true;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x001CD9C8 File Offset: 0x001CBBC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x001CD9D8 File Offset: 0x001CBBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x001CD9E8 File Offset: 0x001CBBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x001CD9F8 File Offset: 0x001CBBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x001CDA08 File Offset: 0x001CBC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x001CDA18 File Offset: 0x001CBC18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectorySettingsEvent other)
		{
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x001CDA28 File Offset: 0x001CBC28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x001CDA38 File Offset: 0x001CBC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001CDA48 File Offset: 0x001CBC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectorySettingsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					JobCrafterDirectorySettingsEvent._parser = new MessageParser<JobCrafterDirectorySettingsEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					JobCrafterDirectorySettingsEvent._repeated_settings_codec = FieldCodec.ForMessage<JobCrafterDirectorySettings>(10U, pdGSb0n7rY1Ec4eviWWW.XVInXhlssT(pdGSb0n7rY1Ec4eviWWW.Iudn7V4pvGY));
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x001CDB50 File Offset: 0x001CBD50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xv1mfSOV0YRWIOZm7cdI()
		{
			return true;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x001CDB58 File Offset: 0x001CBD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectorySettingsEvent VFWbooOVCtj9qHPTGfJO()
		{
			return null;
		}

		// Token: 0x04000FB4 RID: 4020
		private static readonly MessageParser<JobCrafterDirectorySettingsEvent> _parser;

		// Token: 0x04000FB5 RID: 4021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FB6 RID: 4022
		public const int SettingsFieldNumber = 1;

		// Token: 0x04000FB7 RID: 4023
		private static readonly FieldCodec<JobCrafterDirectorySettings> _repeated_settings_codec;

		// Token: 0x04000FB8 RID: 4024
		private readonly RepeatedField<JobCrafterDirectorySettings> settings_;

		// Token: 0x04000FB9 RID: 4025
		internal static JobCrafterDirectorySettingsEvent bR2UO6OVVGWKYhbOErnE;
	}
}
