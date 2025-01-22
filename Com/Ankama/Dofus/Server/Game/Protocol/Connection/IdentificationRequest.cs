using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x02000893 RID: 2195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IdentificationRequest : IMessage<IdentificationRequest>, IMessage, IEquatable<IdentificationRequest>, IDeepCloneable<IdentificationRequest>, IBufferMessage
	{
		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06006A97 RID: 27287 RVA: 0x0022FF38 File Offset: 0x0022E138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IdentificationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x0022FF48 File Offset: 0x0022E148
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

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06006A99 RID: 27289 RVA: 0x0022FF58 File Offset: 0x0022E158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x0022FF68 File Offset: 0x0022E168
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest()
		{
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x0022FF78 File Offset: 0x0022E178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest(IdentificationRequest other)
		{
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x0022FF88 File Offset: 0x0022E188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest Clone()
		{
			return null;
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x0022FF98 File Offset: 0x0022E198
		// (set) Token: 0x06006A9E RID: 27294 RVA: 0x0022FFA8 File Offset: 0x0022E1A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string TicketKey
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

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x0022FFB8 File Offset: 0x0022E1B8
		// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x0022FFC8 File Offset: 0x0022E1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LanguageCode
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

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0022FFD8 File Offset: 0x0022E1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x0022FFE8 File Offset: 0x0022E1E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IdentificationRequest other)
		{
			return true;
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x0022FFF8 File Offset: 0x0022E1F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00230008 File Offset: 0x0022E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00230018 File Offset: 0x0022E218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00230028 File Offset: 0x0022E228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00230038 File Offset: 0x0022E238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00230048 File Offset: 0x0022E248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(IdentificationRequest other)
		{
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x00230058 File Offset: 0x0022E258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00230068 File Offset: 0x0022E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x00230078 File Offset: 0x0022E278
		[MethodImpl(MethodImplOptions.NoInlining)]
		static IdentificationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				IdentificationRequest._parser = new MessageParser<IdentificationRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x0023015C File Offset: 0x0022E35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X6ImFWJmOaS3gwP3EruV()
		{
			return true;
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x00230164 File Offset: 0x0022E364
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IdentificationRequest DNgp4NJmJeX29f0eHuNV()
		{
			return null;
		}

		// Token: 0x04002550 RID: 9552
		private static readonly MessageParser<IdentificationRequest> _parser;

		// Token: 0x04002551 RID: 9553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002552 RID: 9554
		public const int TicketKeyFieldNumber = 1;

		// Token: 0x04002553 RID: 9555
		private string ticketKey_;

		// Token: 0x04002554 RID: 9556
		public const int LanguageCodeFieldNumber = 2;

		// Token: 0x04002555 RID: 9557
		private string languageCode_;

		// Token: 0x04002556 RID: 9558
		internal static IdentificationRequest UhV1SlJmRTnsLebRy95q;
	}
}
