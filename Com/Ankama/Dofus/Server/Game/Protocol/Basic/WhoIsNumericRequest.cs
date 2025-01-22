using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BBE RID: 3006
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoIsNumericRequest : IMessage<WhoIsNumericRequest>, IMessage, IEquatable<WhoIsNumericRequest>, IDeepCloneable<WhoIsNumericRequest>, IBufferMessage
	{
		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060090A0 RID: 37024 RVA: 0x0026EA7C File Offset: 0x0026CC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WhoIsNumericRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060090A1 RID: 37025 RVA: 0x0026EA8C File Offset: 0x0026CC8C
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060090A2 RID: 37026 RVA: 0x0026EA9C File Offset: 0x0026CC9C
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

		// Token: 0x060090A3 RID: 37027 RVA: 0x0026EAAC File Offset: 0x0026CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericRequest()
		{
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0026EABC File Offset: 0x0026CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericRequest(WhoIsNumericRequest other)
		{
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x0026EACC File Offset: 0x0026CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x0026EADC File Offset: 0x0026CCDC
		// (set) Token: 0x060090A7 RID: 37031 RVA: 0x0026EAEC File Offset: 0x0026CCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0026EAFC File Offset: 0x0026CCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060090A9 RID: 37033 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoIsNumericRequest other)
		{
			return true;
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x0026EB1C File Offset: 0x0026CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x0026EB2C File Offset: 0x0026CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x0026EB3C File Offset: 0x0026CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x0026EB4C File Offset: 0x0026CD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x0026EB5C File Offset: 0x0026CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x0026EB6C File Offset: 0x0026CD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoIsNumericRequest other)
		{
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x0026EB7C File Offset: 0x0026CD7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x0026EB8C File Offset: 0x0026CD8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x0026EB9C File Offset: 0x0026CD9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoIsNumericRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				WhoIsNumericRequest._parser = new MessageParser<WhoIsNumericRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x0026EC68 File Offset: 0x0026CE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AhiZi9J2UiEgXZUyt5Mv()
		{
			return true;
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x0026EC70 File Offset: 0x0026CE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoIsNumericRequest idtfu4J2v91Okk0lGxlK()
		{
			return null;
		}

		// Token: 0x040035D6 RID: 13782
		private static readonly MessageParser<WhoIsNumericRequest> _parser;

		// Token: 0x040035D7 RID: 13783
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D8 RID: 13784
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040035D9 RID: 13785
		private long playerId_;

		// Token: 0x040035DA RID: 13786
		internal static WhoIsNumericRequest JEgh0eJ2c94UFhWFA0UN;
	}
}
