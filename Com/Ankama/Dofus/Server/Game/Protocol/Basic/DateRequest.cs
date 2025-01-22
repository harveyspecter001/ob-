using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BB8 RID: 3000
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DateRequest : IMessage<DateRequest>, IMessage, IEquatable<DateRequest>, IDeepCloneable<DateRequest>, IBufferMessage
	{
		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x0026E46C File Offset: 0x0026C66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06009053 RID: 36947 RVA: 0x0026E47C File Offset: 0x0026C67C
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06009054 RID: 36948 RVA: 0x0026E48C File Offset: 0x0026C68C
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

		// Token: 0x06009055 RID: 36949 RVA: 0x0026E49C File Offset: 0x0026C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateRequest()
		{
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x0026E4AC File Offset: 0x0026C6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateRequest(DateRequest other)
		{
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x0026E4BC File Offset: 0x0026C6BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateRequest Clone()
		{
			return null;
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0026E4CC File Offset: 0x0026C6CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x0026E4DC File Offset: 0x0026C6DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DateRequest other)
		{
			return true;
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x0026E4EC File Offset: 0x0026C6EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x0026E4FC File Offset: 0x0026C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x0026E50C File Offset: 0x0026C70C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x0026E51C File Offset: 0x0026C71C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0026E52C File Offset: 0x0026C72C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0026E53C File Offset: 0x0026C73C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DateRequest other)
		{
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x0026E54C File Offset: 0x0026C74C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x0026E55C File Offset: 0x0026C75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0026E56C File Offset: 0x0026C76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					DateRequest._parser = new MessageParser<DateRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x0026E638 File Offset: 0x0026C838
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YGX6W6J2N7hodc1XyIFk()
		{
			return true;
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x0026E640 File Offset: 0x0026C840
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateRequest SAv4DpJ2xypE0VYhWAFG()
		{
			return null;
		}

		// Token: 0x040035C1 RID: 13761
		private static readonly MessageParser<DateRequest> _parser;

		// Token: 0x040035C2 RID: 13762
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C3 RID: 13763
		private static DateRequest FPVH4wJ2XlNVaSeoaEEj;
	}
}
