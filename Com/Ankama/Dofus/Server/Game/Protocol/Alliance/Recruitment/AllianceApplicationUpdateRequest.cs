using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D04 RID: 3332
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationUpdateRequest : IMessage<AllianceApplicationUpdateRequest>, IMessage, IEquatable<AllianceApplicationUpdateRequest>, IDeepCloneable<AllianceApplicationUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600A04D RID: 41037 RVA: 0x00287904 File Offset: 0x00285B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600A04E RID: 41038 RVA: 0x00287914 File Offset: 0x00285B14
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

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600A04F RID: 41039 RVA: 0x00287924 File Offset: 0x00285B24
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

		// Token: 0x0600A050 RID: 41040 RVA: 0x00287934 File Offset: 0x00285B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationUpdateRequest()
		{
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x00287944 File Offset: 0x00285B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationUpdateRequest(AllianceApplicationUpdateRequest other)
		{
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x00287954 File Offset: 0x00285B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600A053 RID: 41043 RVA: 0x00287964 File Offset: 0x00285B64
		// (set) Token: 0x0600A054 RID: 41044 RVA: 0x00287974 File Offset: 0x00285B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AllianceUid
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600A055 RID: 41045 RVA: 0x00287984 File Offset: 0x00285B84
		// (set) Token: 0x0600A056 RID: 41046 RVA: 0x00287994 File Offset: 0x00285B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Text
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

		// Token: 0x0600A057 RID: 41047 RVA: 0x002879A4 File Offset: 0x00285BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x002879B4 File Offset: 0x00285BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationUpdateRequest other)
		{
			return true;
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x002879C4 File Offset: 0x00285BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x002879D4 File Offset: 0x00285BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x002879E4 File Offset: 0x00285BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x002879F4 File Offset: 0x00285BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x00287A04 File Offset: 0x00285C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x00287A14 File Offset: 0x00285C14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationUpdateRequest other)
		{
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x00287A24 File Offset: 0x00285C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x00287A34 File Offset: 0x00285C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x00287A44 File Offset: 0x00285C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationUpdateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					AllianceApplicationUpdateRequest._parser = new MessageParser<AllianceApplicationUpdateRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x00287B28 File Offset: 0x00285D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S3gO7YJj8Mwa4vyeo6F2()
		{
			return true;
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x00287B30 File Offset: 0x00285D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationUpdateRequest mmy9InJjZO4IVUdiU8Ro()
		{
			return null;
		}

		// Token: 0x04003B53 RID: 15187
		private static readonly MessageParser<AllianceApplicationUpdateRequest> _parser;

		// Token: 0x04003B54 RID: 15188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B55 RID: 15189
		public const int AllianceUidFieldNumber = 1;

		// Token: 0x04003B56 RID: 15190
		private string allianceUid_;

		// Token: 0x04003B57 RID: 15191
		public const int TextFieldNumber = 2;

		// Token: 0x04003B58 RID: 15192
		private string text_;

		// Token: 0x04003B59 RID: 15193
		internal static AllianceApplicationUpdateRequest tlJkidJjuCX7QPkiLgnE;
	}
}
