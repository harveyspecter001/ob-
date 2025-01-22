using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B78 RID: 2936
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismModule : IMessage<PrismModule>, IMessage, IEquatable<PrismModule>, IDeepCloneable<PrismModule>, IBufferMessage
	{
		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x0026A064 File Offset: 0x00268264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismModule> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x0026A074 File Offset: 0x00268274
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

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x0026A084 File Offset: 0x00268284
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

		// Token: 0x06008CE4 RID: 36068 RVA: 0x0026A094 File Offset: 0x00268294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismModule()
		{
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x0026A0A4 File Offset: 0x002682A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismModule(PrismModule other)
		{
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x0026A0B4 File Offset: 0x002682B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismModule Clone()
		{
			return null;
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x0026A0C4 File Offset: 0x002682C4
		// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x0026A0D4 File Offset: 0x002682D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectItemInventory ModuleObject
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

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0026A0E4 File Offset: 0x002682E4
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0026A0F8 File Offset: 0x002682F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismModule.Types.PrismModuleType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PrismModule.Types.PrismModuleType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x0026A108 File Offset: 0x00268308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x0026A118 File Offset: 0x00268318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismModule other)
		{
			return true;
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x0026A128 File Offset: 0x00268328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x0026A138 File Offset: 0x00268338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x0026A148 File Offset: 0x00268348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x0026A158 File Offset: 0x00268358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x0026A168 File Offset: 0x00268368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x0026A178 File Offset: 0x00268378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismModule other)
		{
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x0026A188 File Offset: 0x00268388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x0026A198 File Offset: 0x00268398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x0026A1A8 File Offset: 0x002683A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismModule()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PrismModule._parser = new MessageParser<PrismModule>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x0026A28C File Offset: 0x0026848C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T4yxnHJ94OdggclqcTTE()
		{
			return true;
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x0026A294 File Offset: 0x00268494
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismModule HRA8MYJ9j4xJ8rwO6Hi5()
		{
			return null;
		}

		// Token: 0x0400341F RID: 13343
		private static readonly MessageParser<PrismModule> _parser;

		// Token: 0x04003420 RID: 13344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003421 RID: 13345
		public const int ModuleObjectFieldNumber = 1;

		// Token: 0x04003422 RID: 13346
		private ObjectItemInventory moduleObject_;

		// Token: 0x04003423 RID: 13347
		public const int TypeFieldNumber = 2;

		// Token: 0x04003424 RID: 13348
		private PrismModule.Types.PrismModuleType type_;

		// Token: 0x04003425 RID: 13349
		internal static PrismModule pUkBOGJ9xsDI0CmCI8AQ;

		// Token: 0x02000B79 RID: 2937
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008CF8 RID: 36088 RVA: 0x002E44A0 File Offset: 0x002E26A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B7A RID: 2938
			public enum PrismModuleType
			{
				// Token: 0x04003427 RID: 13351
				[OriginalName("NO_MODULE")]
				NoModule,
				// Token: 0x04003428 RID: 13352
				[OriginalName("TELEPORTER")]
				Teleporter,
				// Token: 0x04003429 RID: 13353
				[OriginalName("RECYCLER")]
				Recycler
			}
		}
	}
}
