using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security
{
	// Token: 0x0200016E RID: 366
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FileCheckRequest : IMessage<FileCheckRequest>, IMessage, IEquatable<FileCheckRequest>, IDeepCloneable<FileCheckRequest>, IBufferMessage
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0019EEF0 File Offset: 0x0019D0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileCheckRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0019EF00 File Offset: 0x0019D100
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0019EF10 File Offset: 0x0019D110
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

		// Token: 0x060010B5 RID: 4277 RVA: 0x0019EF20 File Offset: 0x0019D120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckRequest()
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0019EF30 File Offset: 0x0019D130
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckRequest(FileCheckRequest other)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0019EF40 File Offset: 0x0019D140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileCheckRequest Clone()
		{
			return null;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0019EF50 File Offset: 0x0019D150
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x0019EF64 File Offset: 0x0019D164
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CheckType CheckType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CheckType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0019EF74 File Offset: 0x0019D174
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x0019EF84 File Offset: 0x0019D184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Value
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

		// Token: 0x060010BC RID: 4284 RVA: 0x0019EF94 File Offset: 0x0019D194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0019EFA4 File Offset: 0x0019D1A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FileCheckRequest other)
		{
			return true;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0019EFB4 File Offset: 0x0019D1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0019EFC4 File Offset: 0x0019D1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0019EFD4 File Offset: 0x0019D1D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0019EFE4 File Offset: 0x0019D1E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0019EFF4 File Offset: 0x0019D1F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0019F004 File Offset: 0x0019D204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FileCheckRequest other)
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0019F014 File Offset: 0x0019D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0019F024 File Offset: 0x0019D224
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0019F034 File Offset: 0x0019D234
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FileCheckRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				FileCheckRequest._parser = new MessageParser<FileCheckRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0019F12C File Offset: 0x0019D32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bNyflfOvearS9GlxZOjp()
		{
			return true;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0019F134 File Offset: 0x0019D334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FileCheckRequest MS2VjLOv3SILooP904gF()
		{
			return null;
		}

		// Token: 0x04000618 RID: 1560
		private static readonly MessageParser<FileCheckRequest> _parser;

		// Token: 0x04000619 RID: 1561
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400061A RID: 1562
		public const int CheckTypeFieldNumber = 1;

		// Token: 0x0400061B RID: 1563
		private CheckType checkType_;

		// Token: 0x0400061C RID: 1564
		public const int ValueFieldNumber = 2;

		// Token: 0x0400061D RID: 1565
		private string value_;

		// Token: 0x0400061E RID: 1566
		internal static FileCheckRequest Cy2svZOvBDcIPTqEoMW1;
	}
}
