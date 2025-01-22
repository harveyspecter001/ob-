using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200026B RID: 619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetInfoRequest : IMessage<ForgettableSpellPresetInfoRequest>, IMessage, IEquatable<ForgettableSpellPresetInfoRequest>, IDeepCloneable<ForgettableSpellPresetInfoRequest>, IBufferMessage
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x001B287C File Offset: 0x001B0A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellPresetInfoRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x001B288C File Offset: 0x001B0A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x001B289C File Offset: 0x001B0A9C
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

		// Token: 0x06001CDA RID: 7386 RVA: 0x001B28AC File Offset: 0x001B0AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoRequest()
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x001B28BC File Offset: 0x001B0ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoRequest(ForgettableSpellPresetInfoRequest other)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x001B28CC File Offset: 0x001B0ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoRequest Clone()
		{
			return null;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x001B28DC File Offset: 0x001B0ADC
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x001B28EC File Offset: 0x001B0AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PresetUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x001B28FC File Offset: 0x001B0AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x001B290C File Offset: 0x001B0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetInfoRequest other)
		{
			return true;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x001B291C File Offset: 0x001B0B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x001B292C File Offset: 0x001B0B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x001B293C File Offset: 0x001B0B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x001B294C File Offset: 0x001B0B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x001B295C File Offset: 0x001B0B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x001B296C File Offset: 0x001B0B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetInfoRequest other)
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x001B297C File Offset: 0x001B0B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x001B298C File Offset: 0x001B0B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x001B299C File Offset: 0x001B0B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetInfoRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				ForgettableSpellPresetInfoRequest._parser = new MessageParser<ForgettableSpellPresetInfoRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x001B2A80 File Offset: 0x001B0C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FEBd6VO5DbTI31uO0D0H()
		{
			return true;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x001B2A88 File Offset: 0x001B0C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetInfoRequest uB2sv3O5tj9oQdooaII0()
		{
			return null;
		}

		// Token: 0x04000A3B RID: 2619
		private static readonly MessageParser<ForgettableSpellPresetInfoRequest> _parser;

		// Token: 0x04000A3C RID: 2620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A3D RID: 2621
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000A3E RID: 2622
		private string presetUuid_;

		// Token: 0x04000A3F RID: 2623
		internal static ForgettableSpellPresetInfoRequest H6Vb9gO5CyUQG5bLiH0e;
	}
}
